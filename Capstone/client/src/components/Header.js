import React from 'react';
import { Link } from 'react-router-dom';

function Header(props) {
 
  return (
    <nav className="navheader">
      <ul className="nav-items">
        {
          props.user ? (
            <>
              <li className="nav-item"><Link to='/'>Dashboard</Link></li>
              <li className="nav-item"><Link to='/CheckIns'>CheckIn</Link></li>
              <li className="nav-item"><Link to='/Connect'>Connect</Link></li>
              <li className="nav-item"><Link to='/CreateCare'>CreateCare</Link></li>
              <li className="nav-item">Hello {props.user.username}</li>
              <li className="nav-item" onClick={props.logout}>Log out</li>
            </>
          ) : (
              <>
                <li className="nav-item">
                  <Link to="/login">Login</Link>
                </li>
                <li className="nav-item">
                  <Link to="/register">Register</Link>
                </li>
              </>
            )
        }
      </ul>
    </nav>
  )
}

export default Header;