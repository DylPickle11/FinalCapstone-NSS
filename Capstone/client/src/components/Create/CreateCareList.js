import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import { Button, Header, Modal, Image } from 'semantic-ui-react'



export default class CreateCareList extends Component {
    state = {
        Quotes: []
    }

    componentDidMount() {
        APIManager.getQuotes().then((quotes) => {
            this.setState({
                Quotes: quotes
            })
            console.log(this.state.Quotes.contents.quotes[0])
        })
    }
    quote = () => {
        let Quote = this.state.Quotes.contents.quotes[0].quote
        console.log(Quote)
    }


    render() {
        return (
            <>
                <Header as='h1'>Create Care</Header>
                <Header as='h2'>Click on a button to do an activity!</Header>
                <Button color='orange' size='massive' id="meditate"><a href='http://www.onlinemeditationtimer.com/'>Meditation Timer</a></Button>
                <Button color='teal' size='massive' id="art"><a href='https://sketch.io/sketchpad/'>Create Art</a></Button>
                <Button color='violet' size='massive' id="music"><a href='https://www.onlinepianist.com/virtual-piano'>Create Music</a></Button> 
                {(this.state.Quotes.contents) ?
                    <Modal trigger={<Button color='pink' size='massive' id="quotes">Get Quotes</Button>}>
                        <br />
                        <Modal.Header>{this.state.Quotes.contents.quotes[0].title}</Modal.Header>
                        <Modal.Content image>
                            <Image wrapped size='medium' src={require('../../Images/kittyNap.png')} />
                            <Modal.Description>
                                <Header>Details</Header>
                                <p><strong>Quote:</strong>{this.state.Quotes.contents.quotes[0].quote}</p>
                                <p><strong>Author:</strong>{this.state.Quotes.contents.quotes[0].author}</p>
                                <p><strong>Category:</strong>{this.state.Quotes.contents.quotes[0].title}</p>
                            </Modal.Description>
                        </Modal.Content>
                    </Modal>
                    : <h3>Getting the Quote</h3>}
                <span /*style="z-index:50;font-size:0.9em;"*/><img src="https://theysaidso.com/branding/theysaidso.png" height="20" width="20" alt="theysaidso.com" />
                    <a href="https://theysaidso.com" title="Powered by quotes from theysaidso.com" /*style="color: #9fcc25; margin-left: 4px; vertical-align: middle;"*/>theysaidso.com</a></span>

            </>
        )
    }
}