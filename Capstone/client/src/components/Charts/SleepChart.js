import React, { Component } from 'react';
import { Bar } from 'react-chartjs-2';




export default class SleepChart extends Component {
    render() {

        const data = {
            labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
            datasets: [
                {
                    label: "Sleep Hours",
                    data: this.props.sleepHours,
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