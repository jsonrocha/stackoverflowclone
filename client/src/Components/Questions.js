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
      fetch("http://localhost:5000/api/Question")
        .then(resp => resp.json())
        .then(questionsData => {
          console.log(questionsData);
          this.setState({
            questions: questionsData
          });
        });
  
        fetch("http://localhost:5001/api/Answer")
        .then(resp => resp.json())
        .then(answersData => {
          console.log(answersData);
          this.setState({
            answers: answersData
          });
        });
    }
  
    render() {
      return (
        <body>
        <NavBar />
          <div>
            <h1>All Questions</h1>
            <Link to="">Ask Question</Link>
          </div>
          {this.state.questions.map((question, i) => {
            return (
              <div key={i}>
                <div>
                  <div>
                    <p>{question.upVotes - question.downVotes}</p>
                    <p>Votes</p>
                  </div>
                  <div>
                    <p>{this.state.answers.length}</p>
                    <p>Answers</p>
                  </div>
                </div>
                <div>
                  <Link to={`./${question.id}`}>
                    <p className="question">{question.title}</p>
                  </Link>
                  <p>Asked {this.getDate(question.date)}</p>
                </div>
              </div>
            );
          })}
        </body>
      );
    }
  }
  
  export default Questions;