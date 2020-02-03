import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import Home from './Home';
import CheckInList from './CheckIns/CheckInsList';
import CheckInForm from './CheckIns/CheckInForm';
import CheckInDetails from './CheckIns/CheckInDetails';


export default class ApplicationViews extends Component {
    render() {

        return (
            <>
                <Route exact path='/' render={(props) => {
                    return <Home {...this.props} />
                }} />
                <Route exact path='/CheckIns' render={(props) => {
                    return <CheckInList {...this.props} />
                }} />
                <Route exact path='/CheckIns/New' render={(props) => {
                    return <CheckInForm {...this.props} />
                }} />
                <Route exact path='/CheckIns/:checkInId(\d+)' render={(props) => {
                    return <CheckInDetails {...this.props} />
                }} />

            </>

        )
    }
}
