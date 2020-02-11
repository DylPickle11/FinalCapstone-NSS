import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import { Button, Card } from 'semantic-ui-react'



export default class CheckInCard extends Component {
 handleDelete = () => {
     APIManager.deleteUserData("TherapistUsers", this.props.therapist.id)  
     .then(() => this.props.history.push("/Connect"))
 }
    render() {
        return (
            <>
             <Card>
                    <Card.Content>
                        <i className="circular red right floated heart icon" ></i> 
                        <Card.Header>{this.props.therapist.therapist.name}</Card.Header>
                        <Card.Meta>{this.props.therapist.therapist.title}</Card.Meta>
                        <Card.Description>{this.props.therapist.therapist.address}</Card.Description>
                        <Card.Description>{this.props.therapist.therapist.city}</Card.Description>
                        <Card.Description>{this.props.therapist.therapist.state}</Card.Description>
                        <Card.Description>{this.props.therapist.therapist.zipCode}</Card.Description>
                        <Card.Description>{this.props.therapist.therapist.phone}</Card.Description>
                    </Card.Content>
                    <Card.Content extra>
                        <Button id="remove" basic color='red' onClick={this.handleDelete}>Remove</Button>
                    </Card.Content>
                </Card>         
            </>
        )
    }
}