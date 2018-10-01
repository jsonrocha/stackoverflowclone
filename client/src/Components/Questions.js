import React, { Component } from 'react';
import { Link } from "react-router-dom";
import NavBar from './NavBar'

class Questions extends Component {
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
        <div>
        <NavBar />
          <div>
            <h1>All Questions</h1>
            <Link to="">Ask Question</Link>
          </div>
          {this.state.questions.map((question, i)=> {
            return (
              <div key={i}>
                <div>
                <p>{this.state.questions[i].question}</p>
                </div>
              </div>
            );
          })}
        </div>
      );
    }
  }
  
  export default Questions;