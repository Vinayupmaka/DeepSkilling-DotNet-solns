import React from 'react';

function UserPage() {
  return (
    <div>
      <h2>Welcome Back!</h2>
      <p>You can now book your tickets.</p>
      <button onClick={() => alert("Ticket Booked!")}>Book Ticket</button>
    </div>
  );
}

export default UserPage;
