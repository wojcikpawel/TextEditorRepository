import React from "react";
import { Route, Switch } from "react-router-dom";



// FREE

import HomePage from "./pages/HomePage";
import HelloWorld from './pages/HelloWorld';
import Dashboard from './pages/Dashboard';

class Routes extends React.Component {
  render() {
    return (
      <Switch>
        <Route exact path="/" component={HomePage} />
        <Route exact path="/HelloWorld" component={HelloWorld} />
        <Route exact pat="/Dashboard" component={Dashboard} />
        <Route
          render={function() {
            return <h1>Not Found</h1>;
          }}
        />
      </Switch>
    );
  }
}

export default Routes;
