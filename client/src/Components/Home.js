import React, { Component } from 'react';
import NavBar from './NavBar'

class Home extends Component {
    render() {
        return (
            <div>
            <header>
            <span><img className="logo" src="./images/stackoverflowlogo.png" alt="logo" /></span>
            <input className="search" placeholder="Search..."></input>
            </header>
            <div className="flex">
            <div className="sidebar">
            <NavBar />
            </div>
            <div className="right"><p>Testing</p></div>
            </div>
            </div>
        );
    }
}

export default Home;
