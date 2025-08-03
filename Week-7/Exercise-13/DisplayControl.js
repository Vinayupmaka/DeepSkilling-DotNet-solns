    import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function DisplayControl() {
  const [view, setView] = useState('book');

  return (
    <div>
      <h1 style={{ fontSize: '36px' }}>📖 Blogger App</h1>

      <div>
        <button onClick={() => setView('book')}>Show Books</button>
        <button onClick={() => setView('blog')}>Show Blogs</button>
        <button onClick={() => setView('course')}>Show Courses</button>
      </div>

      <div style={{ marginTop: '20px' }}>
        {view === 'book' && <BookDetails />}
        {view === 'blog' && <BlogDetails />}
        {view === 'course' && <CourseDetails />}
      </div>
    </div>
  );
}

export default DisplayControl;
