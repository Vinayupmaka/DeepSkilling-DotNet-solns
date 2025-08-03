import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState(null);

  const handleSubmit = (event) => {
    event.preventDefault(); // Synthetic event handling
    if (!rupees || isNaN(rupees)) {
      alert('Please enter a valid number in Rupees 🪙');
      return;
    }
    const converted = (parseFloat(rupees) / 88).toFixed(2); // Assuming 1 Euro = ₹88
    setEuro(converted);
  };

  return (
    <div style={{ marginTop: '30px' }}>
      <h2>💱 Currency Convertor</h2>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          placeholder="Enter amount in ₹ Rupees"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
        />
        <button type="submit">Convert to Euro</button>
      </form>

      {euro !== null && (
        <p style={{ color: 'green' }}>
          💶 Equivalent in Euros: <strong>€{euro}</strong>
        </p>
      )}
    </div>
  );
}

export default CurrencyConvertor;
