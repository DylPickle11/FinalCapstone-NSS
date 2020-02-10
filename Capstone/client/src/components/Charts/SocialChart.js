import React, { Component } from 'react';
import { Pie } from 'react-chartjs-2';



export default class MoodChart extends Component {
    render() {
        const ConflictCount =  this.props.social.filter(e => e === "Conflict").length
        const SupportiveCount =  this.props.social.filter(e => e === "Supportive").length
        const SociableCount =  this.props.social.filter(e => e === "Sociable").length
        const WithdrawnCount =  this.props.social.filter(e => e === "Withdrawn").length
        
        const data = {
            
            labels: ["Conflict", "Supportive", "Sociable", "Withdrawn"],
            datasets: [
                {
                    label: "Social",
                    data: [ConflictCount, SupportiveCount, SociableCount, WithdrawnCount],
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)'
                    ],
                }
            ]
        }
        return (
            <div >
                <Pie
                    data={data}
                    width={150}
                    height={150}
                //options={{ maintainAspectRatio: false }}
                />
            </div>
        )
    }
}