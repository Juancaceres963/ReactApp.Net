import React, { Component } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render() {
    return (
      <header>
        <Navbar className="navbar navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" container light>
            <NavbarBrand href="/">
                <img className="nav-logo-img" alt="logo" src="https://i.imgur.com/0nCLxdQ.png"/>
            </NavbarBrand>
          <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
          <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                    <ul className="navbar-nav navbar-list flex-grow">
              <NavItem>
                <NavLink tag={Link} className="text-white" to="/">SOBRE MI</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-white" to="/galeria">GALERIA</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-white" to="/comentarios">COMENTARIOS</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-white" to="/contacto">CONTACTO</NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Navbar>
      </header>
    );
  }
}
