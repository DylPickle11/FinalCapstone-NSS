import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import APIManager from '../../API/APIManager';
import SleepChart from '../Charts/SleepChart';
import AttentionChart from '../Charts/AttentionChart';
import EnergyChart from '../Charts/EnergyChart';
import ExerciseChart from '../Charts/ExerciseChart';
import MoodChart from '../Charts/MoodChart';
import MotivationChart from '../Charts/MotivationChart';
import SleepQualityChart from '../Charts/SleepQualityChart';
import SocialChart from '../Charts/SocialChart';



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
            //return true).then(()=>{

            //})
            /// Promise . All
            // this.setState({
            //     singlecheckIns: singlecheckIns,
            //     sleepHours: sleepHours,
            //     sleepQualities: sleepQualities,
            //     meals: meals,
            //     emotions: emotions,
            //     energies: energies,
            //     motviations: motivations,
            //     attentions: attentions,
            //     socials: socials,
            //     exerciseHours: exerciseHours
            // })
        })       
    }

    render() {
        console.log(this.state.sleepHours)
        return (
            <>
                {/* {(this.state.singlecheckIns.id) ? */}
                <div>
                    <SleepChart sleepHours={this.state.sleepHours} />
                    {/* {this.state.attentions.map(attention => (
                            <AttentionChart />
                        ))}
                        {this.state.energies.map(energy => (
                            <EnergyChart />
                        ))} */}
                    {this.state.exerciseHours.map(exercise => (
                        <ExerciseChart key={exercise.id} exercise={exercise} {...this.props} />
                    ))}
                    {/* {this.state.emotions.map(emotion => (
                            <MoodChart />
                        ))}
                        {this.state.motivations.map(motivation => (
                            <MotivationChart />
                        ))}
                        {this.state.sleepQualities.map(sleepQuality => (
                            <SleepQualityChart />
                        ))}
                        {this.state.social.map(social => (
                            <SocialChart />
                        ))} */}
                </div>
                {/* : <h3>Getting the Details</h3>} */}
            </>
        )
    }
}