import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import CheckInList from './CheckIns/CheckInsList';
import CheckInForm from './CheckIns/CheckInForm';
import CheckInDetails from './CheckIns/CheckInDetails';
import ConnectList from './Connect/ConnectList';


export default class ApplicationViews extends Component {
    render() {

        return (
            <>
                <Route exact path='/CheckIns' render={(props) => {
                    return <CheckInList {...this.props} {...props} />
                }} />
                <Route exact path='/CheckIns/New' render={(props) => {
                    return <CheckInForm {...this.props} {...props} />
                }} />
                <Route exact path='/CheckIns/:checkInId(\d+)' render={(props) => {
                    return <CheckInDetails {...this.props} {...props} />
                }} />
                <Route exact path='/Connect' render={(props) => {
                    return <ConnectList {...this.props} {...props} />
                }} />

            </>

        )
    }
}
