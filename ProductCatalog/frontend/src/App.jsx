import { useEffect, useRef, useState } from "react";
import "./App.css";

function App() {
  const [products, setProducts] = useState([]);
  const [name, setName] = useState("");
  const [price, setPrice] = useState("");
  const [search, setSearch] = useState("");
  const [highlightedId, setHighlightedId] = useState(null);

  const productRefs = useRef({});

  const API_URL = "http://localhost:5277/api/Product";

  const getProducts = async () => {
    const response = await fetch(API_URL);
    const data = await response.json();
    setProducts(data);
  };

  useEffect(() => {
    getProducts();
  }, []);

  const addProduct = async (event) => {
    event.preventDefault();

    if (!name || !price) return;

    await fetch(API_URL, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        name,
        price: Number(price),
      }),
    });

    setName("");
    setPrice("");

    getProducts();
  };

  const deleteProduct = async (id) => {
    await fetch(`${API_URL}/${id}`, {
      method: "DELETE",
    });

    getProducts();
  };

  const searchProduct = () => {
    const searchedProduct = products.find(
      (product) =>
        product.name.toLowerCase() === search.trim().toLowerCase()
    );

    if (searchedProduct) {
      setHighlightedId(searchedProduct.id);

      productRefs.current[searchedProduct.id]?.scrollIntoView({
        behavior: "smooth",
        block: "center",
      });

      setTimeout(() => {
        setHighlightedId(null);
      }, 2000);
    }
  };

  return (
    <div className="app">
      <header className="header">
        <div className="header-content">
          <div>
            <h1>Product Catalog</h1>
            <p>Manage your products in one place</p>
          </div>

          <div className="product-count">
            <span>{products.length}</span>
            <small>Products</small>
          </div>
        </div>
      </header>

      <main className="main-content">
        <section className="add-product-section">
          <div className="section-heading">
            <h2>Add New Product</h2>
            <p>Add a product to your catalog</p>
          </div>

          <form onSubmit={addProduct} className="product-form">
            <div className="input-group">
              <label>Product Name</label>
              <input
                type="text"
                placeholder="Enter product name"
                value={name}
                onChange={(event) => setName(event.target.value)}
              />
            </div>

            <div className="input-group">
              <label>Price</label>
              <input
                type="number"
                placeholder="Enter price"
                value={price}
                onChange={(event) => setPrice(event.target.value)}
              />
            </div>

            <button type="submit" className="add-button">
              + Add Product
            </button>
          </form>
        </section>

        <section className="products-section">
          <div className="products-heading">
            <div>
              <h2>Your Products</h2>
              <p>Products currently available in your catalog</p>
            </div>

            <div className="search-container">
              <input
                type="text"
                placeholder="Search product"
                value={search}
                onChange={(event) => setSearch(event.target.value)}
                onKeyDown={(event) => {
                  if (event.key === "Enter") {
                    searchProduct();
                  }
                }}
              />

              <button onClick={searchProduct}>
                Search
              </button>
            </div>
          </div>

          {products.length === 0 ? (
            <div className="empty-state">
              <div className="empty-icon">📦</div>
              <h3>No products yet</h3>
              <p>Add your first product using the form above.</p>
            </div>
          ) : (
            <div className="product-list">
              {products.map((product) => (
                <div
                  className={`product-card ${
                    highlightedId === product.id ? "highlight-product" : ""
                  }`}
                  key={product.id}
                  ref={(element) => {
                    productRefs.current[product.id] = element;
                  }}
                >
                  <div className="product-info">
                    <div className="product-icon">
                      {product.name.charAt(0).toUpperCase()}
                    </div>

                    <div>
                      <h3>{product.name}</h3>
                      <p>Product ID: #{product.id}</p>
                    </div>
                  </div>

                  <div className="product-actions">
                    <div className="price">
                      ₹{product.price.toLocaleString()}
                    </div>

                    <button
                      className="delete-button"
                      onClick={() => deleteProduct(product.id)}
                    >
                      Delete
                    </button>
                  </div>
                </div>
              ))}
            </div>
          )}
        </section>
      </main>
    </div>
  );
}

export default App;