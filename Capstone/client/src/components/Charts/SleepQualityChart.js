import React, { Component } from 'react';
import { Line } from 'react-chartjs-2';



export default class MotivationChart extends Component {
    render() {
        const RestfulCount =  this.props.sleepQuality.filter(e => e === "Restful").length
        const InterruptedCount =  this.props.sleepQuality.filter(e => e === "Interrupted Sleep").length
        const UnrestfulCount =  this.props.sleepQuality.filter(e => e === "Unrestful").length
        const NoSleepCount =  this.props.sleepQuality.filter(e => e === "No Sleep").length
        
        const data = {
            
            labels: ["Restful", "Interrupted", "Unrestful", "No Sleep"],
            datasets: [
                {
                    label: "Sleep Quality",
                    data: [RestfulCount, InterruptedCount, UnrestfulCount, NoSleepCount],
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)'
                    ]
                }
            ]
        }
        return (
            <div >
                <Line
                    data={data}
                    width={150}
                    height={150}
                //options={{ maintainAspectRatio: false }}
                />
            </div>
        )
    }
}