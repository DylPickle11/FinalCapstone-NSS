import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import { Button, Card, Image } from 'semantic-ui-react'



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
                <Card>
                    <Card.Content>
                        <Image
                            floated='right'
                            size='mini'
                            src={require('../../Images/cat.png')}
                        />
                        <Card.Header>{this.props.therapist.name}</Card.Header>
                        <Card.Meta>{this.props.therapist.title}</Card.Meta>
                        <Card.Description>{this.props.therapist.address}</Card.Description>
                        <Card.Description>{this.props.therapist.city}</Card.Description>
                        <Card.Description>{this.props.therapist.state}</Card.Description>
                        <Card.Description>{this.props.therapist.zipCode}</Card.Description>
                        <Card.Description>{this.props.therapist.phone}</Card.Description>
                    </Card.Content>
                    <Card.Content extra>
                        <Button basic color='green' id="save" onClick={this.save}>Save</Button>
                    </Card.Content>
                </Card>
            </>
        )
    }
}