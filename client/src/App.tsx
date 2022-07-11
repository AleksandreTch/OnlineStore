import{useEffect, useState} from "react";
import { Product } from "./product";

function App() {
  const[products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch('http://localhost:5000/api/products')
    .then(response => response.json())
    .then(data => setProducts(data))
  }, []);

  function addProduct() {
    setProducts(prevState =>[...prevState, 
      {
        id: prevState.length + 101,
        name:'product' + (prevState.length + 1), 
        price: (prevState.length * 100) + 199.99,
        brand: 'some brand',
        description:'some description',
        pictureUrl: 'http://picsum.photo/200',
      }])
  }

  return (
    <div className='app'>
      <h1>Novus</h1>
      <ul>
        <li></li>
        {products.map(product => (
          <li key={product.id}>{product.name} - {product.price}</li>
        ))}
      </ul>
      <button onClick={addProduct}>Add Product</button>
    </div>
  );
}

export default App;
