import React, { Component } from 'react';
import './App.css';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import Questions from './Components/Questions';
import Home from './Components/Home';

class App extends Component {
  render() {
    return (
      <div className="App">
      <Router>
      <Switch>
      <Route path="/" exact component={Home} />
      <Route path="/:questions" exact component={Questions} />
      </Switch>
      </Router>
      </div>
    );
  }
}

export default App;
