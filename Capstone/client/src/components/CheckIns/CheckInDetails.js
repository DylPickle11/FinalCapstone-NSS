import React, { Component } from 'react';
import APIManager from '../../API/APIManager'



export default class CheckInDetails extends Component {
    state = {
        CheckIn:[]
    }

    componentDidMount() {
        APIManager.getSpecificData("CheckIns", this.props).then((checkIn) => { this.setState({    
                CheckIn: checkIn
            })
       })
        }

    render() {
        console.log(this.props)
        return (
            <>
            
                {/* <div>
                    <p>{this.props.checkIn.dateCreated}</p>
                    <p>{this.props.checkIn.description}</p>
                    <p>{this.props.checkIn.sleepQuality.sleepQualityType}</p>
                    <p>{this.props.checkIn.meal}</p>
                    <p>{this.props.checkIn.energy.energyType}</p>
                    <p>{this.props.checkIn.motivation.motivationType}</p>
                    <p>{this.props.checkIn.attention.attentionType}</p>
                    <p>{this.props.checkIn.social.socialType}</p>
                    <p>{this.props.checkIn.exerciseHours}</p>
                    <button onClick={this.handleDelete}>Remove</button> 
                </div> */}
            </>
        )
    }
}