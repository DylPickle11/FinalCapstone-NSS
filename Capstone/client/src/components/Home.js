import React, { Component } from 'react';
import { createAuthHeaders } from '../API/userManager';
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

    return (
      <>  
         <img src={require('../Images/TherAPPiLogo.png')}/>
          <h1>Your Week</h1>
          <Dashboard />
      
      </>
        )
      }
    }
    
export default Home;