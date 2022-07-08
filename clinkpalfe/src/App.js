import './App.css';

import React, { useEffect, useState } from 'react';

// const cryptoContext = createContext(null);
function App() {
  const [crypto, setCrypto] = useState([]);
  const getData = async () => {
    const response = await fetch('https://localhost:7092/');
    const data = await response.json();
    var list = data.cryptoInfo;
    if (data) setCrypto(list);

  }
  useEffect(() => {
    getData()
  }, [])
  
  
  return (
      <div className='body'>
        <h1 className='ClinkPal'>ClinkPal</h1>
        <body className='card_Board'>
          {crypto.map((crpto, index) => { 
          return (
            <div className='card'>
              <div className='card-inner'>
                <div key={index} className='card-front'>
                  <h2 className='title'>{crpto.symbol}</h2>
                </div>
                <div className='card-back'>
                  <h4>Rank: {crpto.rank}</h4>
                  <h4>Id: {crpto.id}</h4>
                  <h4>Anual Inflation: {crpto.annualInflation}</h4>
                  <h4>Price to Bitcoin: {crpto.btcPrice}</h4>
                  <h4>USD Liquidity: {crpto.usdLiquidity}</h4>
                  <h4>USD Price: {crpto.usdPrice}</h4>
                </div>
              </div>
            </div>
          )})}
          </body>
        {/* <button onClick={getData}>What Ye say</button> */}
      </div>
  );
}

export default App;
