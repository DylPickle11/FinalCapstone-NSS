import React, { Component } from 'react';
import { Link} from 'react-router-dom';
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

    // Grab DAta
    // Server set Date
    // Use Moments.js or backEnd?
    //Pass properties to each chart
    //Route checkins - api/CheckIns/


    render() {
        return (
            <>
            <SleepChart/>
            <AttentionChart/>
            <EnergyChart/>
            <ExerciseChart/>
            <MoodChart/>
            <MotivationChart/>
            <SleepQualityChart/>
            <SocialChart/>


                
            </>
        )
    }
}