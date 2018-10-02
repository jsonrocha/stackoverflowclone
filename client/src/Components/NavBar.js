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
                    <li><Link to="/">Home</Link></li>
                    <li><Link to ="/:questions">All Questions</Link></li>
                    <li><Link to="">Ask a Question</Link></li>
                </ol>
            </div>
                </div>
        )
    }
}

export default NavBar;