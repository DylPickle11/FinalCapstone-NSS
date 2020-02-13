import React, { Component } from "react";
import { Link } from 'react-router-dom';
import APIManager from "../../API/APIManager";
import CheckInCard from './CheckInCard';
import { Button, Header, Image} from 'semantic-ui-react';


export default class CheckInList extends Component {
    state = {
        AllCheckIns: []
    }

    componentDidMount() {
        APIManager.getData('CheckIns').then((checkIns) => {
            this.setState({
                AllCheckIns: checkIns
            })
        })
    }

    render() {
        return (
            <>
                <br />
                <Header as='h1'>CheckIns</Header>
                <Image centered src={require('../../Images/kittyNap.png')}/>              
                <div>
                    <Link to={`CheckIns/New`}><Button size="large" basic color='purple'>New CheckIn</Button></Link>
                </div>
                <br />
                <br />
                <div>
                    <Header as='h2'>Past CheckIns</Header> 
                    {this.state.AllCheckIns.map(checkIns => (
                        <CheckInCard key={checkIns.id} checkIn={checkIns} {...this.props} />
                    ))}             
                </div>
            </>
        )
    }
}
