import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Rohit', score: 85 },
    { name: 'Virat', score: 95 },
    { name: 'Gill', score: 65 },
    { name: 'Rahul', score: 45 },
    { name: 'Hardik', score: 70 },
    { name: 'Jadeja', score: 50 },
    { name: 'Pant', score: 90 },
    { name: 'Bumrah', score: 30 },
    { name: 'Shami', score: 55 },
    { name: 'Surya', score: 88 },
    { name: 'Kuldeep', score: 60 }
  ];

  // Using map to show all players
  const playerList = players.map((player, index) => (
    <li key={index}>{player.name} - {player.score}</li>
  ));

  // Using arrow function to filter
  const below70 = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players:</h2>
      <ul>{playerList}</ul>

      <h3>Players with Score Below 70:</h3>
      <ul>
        {below70.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
