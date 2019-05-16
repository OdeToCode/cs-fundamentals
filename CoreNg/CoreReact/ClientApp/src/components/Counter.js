import React, { Component } from 'react';

export class Counter extends Component {
  displayName = Counter.name

  constructor(props) {
    super(props);
    this.state = { currentCount: 0 };
    this.incrementCounter = this.incrementCounter.bind(this);
  }

  incrementCounter() {
    this.setState({
      currentCount: this.state.currentCount + 4
    });
  }

  render() {
    return (
      <div>
        <h1>Counter</h1>
        <p>This is a simple example of a React component.</p>
        <h3>{this.state.currentCount}</h3>
        <p>Current count: <strong>{this.state.currentCount}</strong></p>
        <p>Current count: <strong>{this.state.currentCount}</strong></p>
        <p>Current count: <strong>{this.state.currentCount}</strong></p>

        <button onClick={this.incrementCounter}>Increment</button>
      </div>
    );
  }
}
