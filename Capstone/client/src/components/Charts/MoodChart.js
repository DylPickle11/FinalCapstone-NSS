import React, { Component } from 'react';
import { Pie } from 'react-chartjs-2';



export default class MoodChart extends Component {
    render() {
        const HappyCount =  this.props.emotion.filter(e => e === "Happy").length
        const SensitiveCount =  this.props.emotion.filter(e => e === "Sensitive").length
        const SadCount =  this.props.emotion.filter(e => e === "Sad").length
        const FrustratedCount =  this.props.emotion.filter(e => e === "Frustrated").length
        
        const data = {
            
            labels: ["Happy", "Sensitive", "Sad", "Frustrated"],
            datasets: [
                {
                    label: "Moods for the Week",
                    data: [HappyCount, SensitiveCount, SadCount, FrustratedCount],
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