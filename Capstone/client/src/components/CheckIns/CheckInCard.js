import React, { Component } from 'react';
import { Link} from 'react-router-dom';
import APIManager from '../../API/APIManager';



export default class CheckInCard extends Component {
 handleDelete = () => {
     APIManager.deleteUserData("CheckIns", this.props.checkIn.id)  
 }

    render() {
        return (
            <>
                <div>
                    <p>{this.props.checkIn.dateCreated}</p>
                    <p>{this.props.checkIn.description}</p>
                    <p>{this.props.checkIn.sleepQuality.sleepQualityType}</p>
                    <p>{this.props.checkIn.meal}</p>
                    <p>{this.props.checkIn.energy.energyType}</p>
                    <p>{this.props.checkIn.motivation.motivationType}</p>
                    <p>{this.props.checkIn.attention.attentionType}</p>
                    <p>{this.props.checkIn.social.socialType}</p>
                    <p>{this.props.checkIn.exerciseHours}</p>
                    <Link to={`/CheckIns/${this.props.checkIn.id}`}><button>Details</button></Link>
                    <button onClick={this.handleDelete}>Remove</button> 
                </div>
            </>
        )
    }
}