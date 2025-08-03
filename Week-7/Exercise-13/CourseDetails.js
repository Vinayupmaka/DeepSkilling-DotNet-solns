import React from 'react';

const courses = [
  { id: 1, name: 'Frontend Development' },
  { id: 2, name: 'Backend with Node.js' },
];

function CourseDetails() {
  return (
    <div>
      <h2 style={{ fontSize: '28px' }}>🎓 Course Details</h2>
      <ul>
        {courses.map((course) => (
          <li key={course.id}>{course.name}</li>
        ))}
      </ul>
    </div>
  );
}

export default CourseDetails;
