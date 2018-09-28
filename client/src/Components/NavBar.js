import React, { Component } from "react";
import { Link } from "react-router-dom";

class NavBar extends Component {
    render() {
        return (
                <ol>
                    <li><Link to="/">Home</Link></li>
                    <li>All Questions</li>
                    <li>Users</li>
                </ol>
        )
    }
}

export default NavBar;