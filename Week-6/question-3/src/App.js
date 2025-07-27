import React from 'react';
import './App.css';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div className="App">
      <CalculateScore 
        name="Vinay Upmaka" 
        school="Greenwich High School" 
        total={420} 
        goal="Become a Top Scorer" 
      />
    </div>
  );
}

export default App;
