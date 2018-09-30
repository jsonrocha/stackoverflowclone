import React, { Component } from "react";
import { Link } from "react-router-dom";

class NavBar extends Component {
    render() {
        return (
            <div>
            <header>
            <span><img className="logo" src="./images/stackoverflowlogo.png" alt="logo" /></span>
            <input className="search" placeholder="Search..."></input>
            </header>
            <div className="sidebar">
            <ol>
                    <li><Link to="/Home">Home</Link></li>
                    <li><Link to ="/Questions">All Questions</Link></li>
                    <li>Users</li>
                </ol>
            </div>
                </div>
        )
    }
}

export default NavBar;