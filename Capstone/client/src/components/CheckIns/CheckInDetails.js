import React, { Component } from 'react';
import APIManager from '../../API/APIManager'



export default class CheckInDetails extends Component {
    state = {
        CheckIn: []
    }

    componentDidMount() {
        APIManager.getSpecificData("CheckIns", 1).then((checkIn) => {
            this.setState({
                CheckIn: checkIn
            })
        })
    }

    render() {
        console.log(this.state.CheckIn)
        return (
            <>
                <h1>Hello</h1>
                {(this.state.CheckIn.id) ?
                    <div>
                        <p>Date: {this.state.CheckIn.dateCreated}</p>
                        <p>Description: {this.state.CheckIn.description}</p>
                        <p>{this.state.CheckIn.sleepQuality.sleepQualityType}</p>
                        <p>Meal: {this.state.CheckIn.meal}</p>
                        <p>{this.state.CheckIn.energy.energyType}</p>
                        <p>{this.state.CheckIn.motivation.motivationType}</p>
                        <p>{this.state.CheckIn.attention.attentionType}</p>
                        <p>{this.state.CheckIn.social.socialType}</p>
                        <p>Exercise Hours: {this.state.CheckIn.exerciseHours}</p>
                        <button onClick={this.handleDelete}>Remove</button>
                    </div>
                    : <h3>Getting the Details</h3>} 
            </>
        )
    }
}