import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';

const styles = require<any>("./Home.scss");

export default class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className={styles.home}>
            <h1>Hello, world!</h1>
        </div>;
    }
}
