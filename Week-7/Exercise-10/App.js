import React from 'react';
function App() {
const heading = <h1>🏢 Office Space Rental App</h1>;
const officeImage = "https://via.placeholder.com/300x150?text=Office+Space";
const office = {
name: "SpaceHub Offices",
rent: 55000,
address: "Koramangala, Bengaluru"
};
const officeList = [
{
name: "SpaceHub Offices",
rent: 55000,
address: "Koramangala, Bengaluru"
},
{
name: "Green Square",
rent: 72000,
address: "Hitech City, Hyderabad"
},
{
name: "SkyView Spaces",
rent: 49000,
address: "Salt Lake, Kolkata"
}
];
const getRentStyle = (rent) => {
    return {
      color: rent < 60000 ? 'red' : 'green',
      fontWeight: 'bold'
    };
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      {heading}
      <img src={officeImage} alt="Office Space" style={{ width: '300px', height: '150px' }} />

      <h2>Single Office Details:</h2>
      <p>Name: {office.name}</p>
      <p style={getRentStyle(office.rent)}>Rent: ₹{office.rent}</p>
      <p>Address: {office.address}</p>

      <hr />

      <h2>All Office Spaces:</h2>
      {officeList.map((item, index) => (
        <div key={index} style={{ marginBottom: '15px' }}>
          <p>Name: {item.name}</p>
          <p style={getRentStyle(item.rent)}>Rent: ₹{item.rent}</p>
          <p>Address: {item.address}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
