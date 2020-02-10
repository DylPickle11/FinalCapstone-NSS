import React, { Component } from "react";
import ConnectCard from './ConnectCard';
import APIManager from "../../API/APIManager";
import { Input, Grid, Image } from 'semantic-ui-react';


export default class ConnectList extends Component {
    state = {
        AllTherapists: [],
        AllMatches: []
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
        APIManager.getData('Therapists').then((therapists) => {
            this.setState({
                AllTherapists: therapists
            })
        })
    }

    render() {
        console.log(this.state.AllMatches)
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
                                <Image src={require('../../Images/cat.png')}/>
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
                            </Grid.Column>
                        </Grid.Row>
                        </Grid>

                </div>
            </>
                )
            }
}