import React, { Component } from "react";
import ConnectCard from './ConnectCard';
import ConnectPreferenceCard from './ConnectPreferenceCard';
import APIManager from "../../API/APIManager";
import { Input, Grid, Image } from 'semantic-ui-react';


export default class ConnectList extends Component {
    state = {
        AllTherapists: [],
        AllMatches: [],
        SavedTherapists: []
    }
    search = () => {
        let searchInput = document.getElementById("search")
        let inputValue = searchInput.value
        let therapistMatches = [];
        console.log(therapistMatches)
        this.state.AllTherapists.map(therapist => {
            console.log(therapist)
            if (therapist.zipCode === inputValue) {
                therapistMatches.push(therapist);
            }
        })
        this.setState({
            AllMatches: therapistMatches
        })
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
        console.log(this.state.SavedTherapists)
        return (
            <>
                <div>
                    <h1>Connect</h1>
                    <div className="ui icon input">
                        <Input type="text" id="search" placeholder="Search..." />
                        <i aria-hidden="true" className="search icon"></i>
                        <button type="submit" onClick={this.search}>Search</button>
                    </div>
                    <Grid columns={3} divided>
                        <Grid.Row>
                            <Grid.Column>
                                <Image src={require('../../Images/cat.png')} />
                                {this.state.AllTherapists.map(therapist => (
                                    <ConnectCard key={therapist.id} therapist={therapist} {...this.props} />
                                ))}


                            </Grid.Column>

                            <Grid.Column>
                                <Image src={require('../../Images/cat.png')} />
                                {this.state.AllMatches.map(therapist => (
                                    <ConnectCard key={therapist.id} therapist={therapist} {...this.props} />
                                ))}
                            </Grid.Column>
                            <Grid.Column>
                                <Image src={require('../../Images/cat.png')} />
                                {this.state.SavedTherapists.map(therapist => (
                                    <ConnectPreferenceCard key={therapist.id} therapist={therapist} {...this.props} />
                                ))}
                            </Grid.Column>
                        </Grid.Row>
                    </Grid>

                </div>
            </>
        )
    }
}