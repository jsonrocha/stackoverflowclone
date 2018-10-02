import React, { Component } from 'react';
import NavBar from './NavBar';
import { Link } from "react-router-dom"

class Home extends Component {
    constructor(props) {
        super(props);
        this.state = {
          questions: [],
          answers: [],
        };
      }
    
      componentDidMount() {
        fetch("https://localhost:5001/api/Question")
          .then(resp => resp.json())
          .then(questionsData => {
            console.log(questionsData);
            this.setState({
              questions: questionsData
            });
          });
  
      }
    render() {
        return (
            <section>
            <NavBar />
            <div>
            <h1>Top Questions</h1>
          </div>
          {this.state.questions.map((question, i)=> {
            return (
              <div className="space" key={i}>
                <div className="headline headlinebox">
                <Link to="">{this.state.questions[i].question}</Link>
                </div>
              </div>
            );
          })}
            </section>
        );
    }
}

export default Home;
