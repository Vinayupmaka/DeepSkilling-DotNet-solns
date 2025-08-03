import React from 'react';

const books = [
  { id: 1, title: 'React Basics', author: 'Dan Abramov' },
  { id: 2, title: 'JavaScript in Depth', author: 'Kyle Simpson' },
];

function BookDetails() {
  return (
    <div>
      <h2 style={{ fontSize: '28px' }}>📚 Book Details</h2>
      <ul>
        {books.map((book) => (
          <li key={book.id}>
            <strong>{book.title}</strong> by {book.author}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BookDetails;
