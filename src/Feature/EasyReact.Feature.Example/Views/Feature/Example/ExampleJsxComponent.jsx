class ExampleJsxComponent extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <h2>Example react component</h2>
                <h4>
                    Component title: {this.props.title}
                </h4>
            </div>
        );
    }
}