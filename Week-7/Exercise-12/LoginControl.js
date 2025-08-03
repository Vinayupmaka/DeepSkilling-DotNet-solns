import React, { useState } from 'react';
import GuestPage from './GuestPage';
import UserPage from './UserPage';

function LoginControl() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  let page;
  let button;

  if (isLoggedIn) {
    page = <UserPage />;
    button = <button onClick={handleLogout}>Logout</button>;
  } else {
    page = <GuestPage />;
    button = <button onClick={handleLogin}>Login</button>;
  }

  return (
    <div>
      {button}
      {page}
    </div>
  );
}

export default LoginControl;
