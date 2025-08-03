import React from 'react';

const IndianPlayers = () => {
  const teamPlayers = [
    'Rohit', 'Virat', 'Gill', 'Rahul', 'Hardik', 'Jadeja',
    'Pant', 'Bumrah', 'Shami', 'Surya', 'Kuldeep'
  ];
  const oddPlayers = teamPlayers.filter((_, index) => index % 2 === 1);
  const evenPlayers = teamPlayers.filter((_, index) => index % 2 === 0);
  const T20players = ['Rohit', 'Gill', 'Surya'];
  const RanjiTrophy = ['Rahul', 'Bumrah', 'Shami'];
  const mergedPlayers = [...T20players, ...RanjiTrophy];
  return (
    <div>
      <h2>Even Team Players</h2>
      <ul>{evenPlayers.map((player, i) => <li key={i}>{player}</li>)}</ul>

      <h2>Odd Team Players</h2>
      <ul>{oddPlayers.map((player, i) => <li key={i}>{player}</li>)}</ul>

      <h2>Merged Players (T20 + Ranji)</h2>
      <ul>{mergedPlayers.map((player, i) => <li key={i}>{player}</li>)}</ul>
    </div>
  );
};

export default IndianPlayers;

