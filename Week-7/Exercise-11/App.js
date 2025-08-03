import React, { Component } from 'react';
import CurrencyConvertor from './CurrencyConvertor';

class App extends Component {
constructor(props) {
super(props);
this.state = {
count: 0,
message: ''
};
}

increment = () => {
this.setState({ count: this.state.count + 1 }, () => {
this.sayHello();
});
};

sayHello = () => {
this.setState({ message: 'Hello! Let’s keep increasing 💪' });
};

decrement = () => {
this.setState({ count: this.state.count - 1, message: '' });
};

sayWelcome = (text) => {
alert(`${text}, have a great day ahead! 🌞`);
};

handleClick = (event) => {
alert('I was clicked! 🎯');
console.log('Synthetic Event:', event);
};

render() {
return (
<div style={{ textAlign: 'center', marginTop: '40px', fontFamily: 'Arial' }}>
<h1>🎉 React Event Handling Demo</h1>
<h2>Counter: {this.state.count}</h2>
<button onClick={this.increment}>Increment</button>&nbsp;
<button onClick={this.decrement}>Decrement</button>
{this.state.message && <p style={{ color: 'blue' }}>{this.state.message}</p>}
<hr style={{ margin: '30px 0' }} />
<button onClick={() => this.sayWelcome('Welcome')}>Say Welcome</button>
<hr style={{ margin: '30px 0' }} />
<button onClick={this.handleClick}>Synthetic Event Button</button>
<hr style={{ margin: '30px 0' }} />
<CurrencyConvertor />
</div>
);
}
}

export default App;
