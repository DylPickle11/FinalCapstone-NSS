import React, { Component } from "react";
import ConnectCard from './ConnectCard';
import ConnectPreferenceCard from './ConnectPreferenceCard';
import APIManager from "../../API/APIManager";
import { Input, Grid, Card, Header, Segment } from 'semantic-ui-react';


export default class ConnectList extends Component {
    state = {
        AllTherapists: [],
        AllMatches: [],
        SavedTherapists: []
    }

    handleKeyPress = (event) => {
        if (event.key === "Enter") {
            this.search();
        }
    }

    search = () => {
        let searchInput = document.getElementById("search")
        let inputValue = searchInput.value
        let therapistMatches = [];

        this.state.AllTherapists.map(therapist => {
            if (therapist.zipCode === inputValue) {
                therapistMatches.push(therapist);
            }
        })
        this.setState({
            AllTherapists: therapistMatches
        })
        inputValue = "";
    }

    componentDidMount() {
        let therapists = []
        APIManager.getData('Therapists')
            .then((therapist => { therapists = therapist }))
            .then(() => APIManager.getData('TherapistUsers'))
            .then(TheUse => {
                this.setState({
                    AllTherapists: therapists,
                    SavedTherapists: TheUse
                })
            })
    }

    render() {

        return (
            <>
                <Header as='h2'>Connect</Header>
                <Grid>
                    <Grid.Row>
                        <Grid.Column>
                            <Header as='h2'>SavedTherapists</Header>
                            <Card.Group>
                                {this.state.SavedTherapists.map(therapist => (
                                    <ConnectPreferenceCard key={therapist.id} therapist={therapist} {...this.props} />
                                ))}
                            </Card.Group>
                        </Grid.Column>
                    </Grid.Row>   
                    <div className="searchDiv">
                    <Segment inverted>    
                        <Input type="text" size="large" id="search" placeholder="Zipcode...Find a Therapist in your area"
                            onKeyPress={this.handleKeyPress} 
                            focus />    
                            </Segment> 
                            </div> 
                    <Grid.Row>
                        <Grid.Column>
                            <Header as='h2'>Nashville Therapists</Header>
                            <Card.Group>
                                {this.state.AllTherapists.map(therapist => (
                                    <ConnectCard key={therapist.id} therapist={therapist} {...this.props} />
                                ))}
                            </Card.Group>

                        </Grid.Column>
                    </Grid.Row>
                </Grid>
            </>
        )
    }
}