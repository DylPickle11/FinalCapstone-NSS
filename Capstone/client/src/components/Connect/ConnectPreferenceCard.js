import React, { Component } from 'react';
import APIManager from '../../API/APIManager';



export default class CheckInCard extends Component {
 handleDelete = () => {
     APIManager.deleteUserData("CheckIns", this.props.checkIn.id)  
 }
    render() {
        console.log(this.props.therapist)
        return (
            <>
                <div>
                    <p>{this.props.therapist.therapist.name}</p>
                    <p>{this.props.therapist.therapist.title}</p>
                    <p>{this.props.therapist.therapist.address}</p>
                    <p>{this.props.therapist.therapist.city}</p>
                    <p>{this.props.therapist.therapist.state}</p>
                    <p>{this.props.therapist.therapist.zipCode}</p>
                    <p>{this.props.therapist.therapist.phone}</p>
                     <button onClick={this.handleDelete}>Remove</button> 
                    {/* <Link to={`/CheckIns/${this.props.checkIn.id}`}><button>Details</button></Link> */}
                    
                </div>
            </>
        )
    }
}