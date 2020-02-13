import React, { Component } from 'react';
import { Bar } from 'react-chartjs-2';


export default class AttentionChart extends Component {
    render() {
        const FocusCount =  this.props.attention.filter(e => e === "Focused").length
        const DistractCount =  this.props.attention.filter(e => e === "Distracted").length
        const CalmCount =  this.props.attention.filter(e => e === "Calm").length
        const StressCount =  this.props.attention.filter(e => e === "Stressed").length

        const data = {
            
            labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
            datasets: [
                {
                    label: "Attention",
                    data: [FocusCount, DistractCount, CalmCount, StressCount],
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
                <Bar
                    data={data}
                    width={150}
                    height={150}
                //options={{ maintainAspectRatio: false }}
                />
            </div>
        )
    }
}