import React, { Component } from 'react';
import { Link} from 'react-router-dom';
import APIManager from '../../API/APIManager';



export default class CheckInCard extends Component {
 handleDelete = () => {
     APIManager.deleteUserData("CheckIns", this.props.checkIn.id)  
 }

 save = () => {
    let savedTherapist = {
        userId: this.props.userId,
        therapistId: this.props.therapist.id
    }
    alert("You have successfully saved a Therapist!")
    APIManager.postData("TherapistUsers", savedTherapist)
    .then(() => this.props.history.push("/Connect"))    


}

    render() {
        return (
            <>
                <div>
                    <p>{this.props.therapist.name}</p>
                    <p>{this.props.therapist.title}</p>
                    <p>{this.props.therapist.address}</p>
                    <p>{this.props.therapist.city}</p>
                    <p>{this.props.therapist.state}</p>
                    <p>{this.props.therapist.zipCode}</p>
                    <p>{this.props.therapist.phone}</p>
                    <button id="save" onClick={this.save}>Save</button>
                    {/* <Link to={`/CheckIns/${this.props.checkIn.id}`}><button>Details</button></Link> */}
                    {/* <button onClick={this.handleDelete}>Remove</button>  */}
                </div>
            </>
        )
    }
}