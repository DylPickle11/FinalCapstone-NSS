import React, { Component } from 'react';
import { Line } from 'react-chartjs-2';



export default class MotivationChart extends Component {
    render() {
        const MotivatedCount =  this.props.motivation.filter(e => e === "Motivated").length
        const UnMotivatedCount =  this.props.motivation.filter(e => e === "Unmotivated").length
        const ProductiveCount =  this.props.motivation.filter(e => e === "Productive").length
        const unProductiveCount =  this.props.motivation.filter(e => e === "Unproductive").length
        
        const data = {
            
            labels: ["Motivated", "UnMotivated", "Productive", "UnProductive"],
            datasets: [
                {
                    label: "Motivation",
                    data: [MotivatedCount, UnMotivatedCount, ProductiveCount, unProductiveCount],
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