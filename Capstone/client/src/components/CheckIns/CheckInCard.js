import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import { Button, List, Modal, Image, Header } from 'semantic-ui-react';



export default class CheckInCard extends Component {
    state = {
        CheckIn: []
    }
    handleDelete = () => {
        APIManager.deleteUserData("CheckIns", this.props.checkIn.id)
    }

    componentDidMount() {
        APIManager.getSpecificData("CheckIns", 1).then((checkIn) => {
            this.setState({
                CheckIn: checkIn
            })
        })
    }

    render() {
        return (
            <>
                <div className='border'>
                <List divided relaxed>
                    <List.Item>
                        <List.Content>
                            <List.Header as='a'><strong>Date:</strong> {this.props.checkIn.dateCreated}</List.Header>
                            <br />
                            <List.Header as='a'><strong>Description:</strong> {this.props.checkIn.description}</List.Header>
                        </List.Content>
                    </List.Item>
                </List>
                
                {(this.state.CheckIn.id) ?
                <Modal trigger={<Button className='details' basic color="teal">Details</Button>}>
                    <br/>
                    <Modal.Header>{this.props.checkIn.dateCreated}</Modal.Header>
                    <Modal.Content image>
                        <Image wrapped size='medium' src={require('../../Images/kittyNap.png')} />
                        <Modal.Description>
                            <Header>Details</Header>
                            <p><strong>Description:</strong> {this.state.CheckIn.description}</p>
                                <p><strong>Sleep Quality:</strong> {this.state.CheckIn.sleepQuality.sleepQualityType}</p>
                                <p><strong>Amount of Meal:</strong> {this.state.CheckIn.meal}</p>
                                <p><strong>Energy Level:</strong> {this.state.CheckIn.energy.energyType}</p>
                                <p><strong>Motivation Level:</strong> {this.state.CheckIn.motivation.motivationType}</p>
                                <p><strong>Attention Level:</strong> {this.state.CheckIn.attention.attentionType}</p>
                                <p><strong>Social Level:</strong> {this.state.CheckIn.social.socialType}</p>
                                <p><strong>Exercise Hours:</strong> {this.state.CheckIn.exerciseHours}</p>     
                        </Modal.Description>
                    </Modal.Content>
                </Modal>
                : <h3>Getting the Details</h3>}
                </div>
                <br/>
            </>
        )
    }
}