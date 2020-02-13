import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import SleepChart from '../Charts/SleepChart';
import AttentionChart from '../Charts/AttentionChart';
import EnergyChart from '../Charts/EnergyChart';
import ExerciseChart from '../Charts/ExerciseChart';
import MoodChart from '../Charts/MoodChart';
import MotivationChart from '../Charts/MotivationChart';
import SleepQualityChart from '../Charts/SleepQualityChart';
import SocialChart from '../Charts/SocialChart';
import { Grid } from 'semantic-ui-react';



export default class Dashboard extends Component {
    state = {
        singlecheckIns: [],
        sleepHours: [],
        sleepQualities: [],
        meals: [],
        emotions: [],
        energies: [],
        motivations: [],
        attentions: [],
        socials: [],
        exerciseHours: []
    }

    componentDidMount() {
        let singlecheckIns = [];
        let sleepHours = [];
        let sleepQualities = [];
        let meals = [];
        let emotions = [];
        let energies = [];
        let motivations = [];
        let attentions = [];
        let socials = [];
        let exerciseHours = [];

        APIManager.getWeekData('CheckIns').then(checkIns => {

            singlecheckIns = checkIns

            sleepHours = singlecheckIns.map(checkins => {
                return checkins.sleepHours
            });
            sleepQualities = singlecheckIns.map(checkins => {
                return checkins.sleepQuality.sleepQualityType
            });
            meals = singlecheckIns.map(checkins => {
                return checkins.meal
            });
            emotions = singlecheckIns.map(checkins => {
                return checkins.emotion.emotionType
            });
            energies = singlecheckIns.map(checkins => {
                return checkins.energy.energyType
            });
            motivations = singlecheckIns.map(checkins => {
                return checkins.motivation.motivationType
            });
            attentions = singlecheckIns.map(checkins => {
                return checkins.attention.attentionType
            });
            socials = singlecheckIns.map(checkins => {
                return checkins.social.socialType
            });
            exerciseHours = singlecheckIns.map(checkins => {
                return checkins.exerciseHours
            });
            // Promise . All
            this.setState({
                singlecheckIns: singlecheckIns,
                sleepHours: sleepHours,
                sleepQualities: sleepQualities,
                meals: meals,
                emotions: emotions,
                energies: energies,
                motivations: motivations,
                attentions: attentions,
                socials: socials,
                exerciseHours: exerciseHours
            })
        })
    }

    render() {
    
        return (
            <>
                <Grid>
                    <Grid.Row columns={3}>
                        <Grid.Column>
                            <SleepChart sleepHours={this.state.sleepHours} />
                        </Grid.Column>
                        <Grid.Column>
                            <AttentionChart attention={this.state.attentions} />
                        </Grid.Column>
                        <Grid.Column>
                            <EnergyChart energy={this.state.energies} />
                        </Grid.Column>
                    </Grid.Row>
                    <Grid.Row columns={2}>
                        <Grid.Column>
                            <MoodChart emotion={this.state.emotions} />
                        </Grid.Column>
                        <Grid.Column>
                            <SocialChart social={this.state.socials} />
                        </Grid.Column>
                    </Grid.Row>
                    <Grid.Row columns={3}>
                        <Grid.Column>
                            <MotivationChart motivation={this.state.motivations} />
                        </Grid.Column>
                        <Grid.Column>
                            <SleepQualityChart sleepQuality={this.state.sleepQualities} />
                        </Grid.Column>
                        <Grid.Column>
                            <ExerciseChart exercise={this.state.exerciseHours} />
                        </Grid.Column>
                    </Grid.Row>

                </Grid>
                {/* : <h3>Getting the Details</h3>} */}
            </>
        )
    }
}