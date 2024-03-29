import React from 'react';
import './App.css';
import Header from './Header';
import Foodlist from './Food/FoodList';

function App() {
  return (
    <div className="App">
      <Header title="Full Stack React & ASP.NET" />
      <Foodlist />
    </div>
  );
}

export default App;
