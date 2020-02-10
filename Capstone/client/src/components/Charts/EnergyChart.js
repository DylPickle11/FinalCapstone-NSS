import React, { Component } from 'react';
import { Doughnut } from 'react-chartjs-2';



export default class EnergyChart extends Component {
    render() {
        const highCount =  this.props.energy.filter(e => e === "High").length
        const lowCount =  this.props.energy.filter(e => e === "Low").length
        const energyCount =  this.props.energy.filter(e => e === "Enrgized").length
        const exhaustCount =  this.props.energy.filter(e => e === "Exhausted").length //using a filter and .length
        const data = {
            labels: ["High", "Low", "Energized", "Exhausted"],
            datasets: [
                {
                    label: "Energy Level",
                    data: [highCount, lowCount, energyCount, exhaustCount],
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
                <Doughnut
                    data={data}
                    width={150}
                    height={150}
                   // options={{ maintainAspectRatio: false }}
                />
            </div>
        )
    }
}