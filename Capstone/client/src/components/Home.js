import React, { Component } from 'react';
import { createAuthHeaders } from '../API/userManager';
import ApplicationViews from './ApplicationView';
import Chart from 'chart.js';
import Dashboard from './Dashboard/Dashboard';


class Home extends Component {
  state = {
    values: [],
  }
 

  //Who makes this request - these lines authenitcate
  componentDidMount() {
    const authHeader = createAuthHeaders();
    fetch('api/v1/values', {
      headers: authHeader
    })
      .then(response => response.json())
      .then(values => {
        this.setState({ values: values });
      });
  }

  render() {
    // var chart = new Chart 
    return (
      <>
      <ApplicationViews {...this.props}/>
        <h1>Welcome to my app</h1>
        <Dashboard/>
        {/* <canvas id="mychart"></canvas> */}
        {/* <ul>
          {
            this.state.values.map(value => <li>{value}</li>)
          }
        </ul> */}
      </>
    )
  }
}

export default Home;