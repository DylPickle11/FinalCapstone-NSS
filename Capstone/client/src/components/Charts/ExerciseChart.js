import React, { Component } from 'react';
import { Bar } from 'react-chartjs-2';



export default class ExerciseChart extends Component {
    render() {

        const data = {
            labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
            datasets: [
                {
                    label: "Amount of Exercise",
                    data: this.props.exercise,
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