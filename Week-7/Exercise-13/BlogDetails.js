import React from 'react';

const blogs = [
  { id: 1, title: 'React Hooks Explained' },
  { id: 2, title: 'Understanding JSX' },
];

function BlogDetails() {
  return (
    <div>
      <h2 style={{ fontSize: '28px' }}>📝 Blog Details</h2>
      <ul>
        {blogs.map((blog) => (
          <li key={blog.id}>{blog.title}</li>
        ))}
      </ul>
    </div>
  );
}

export default BlogDetails;
