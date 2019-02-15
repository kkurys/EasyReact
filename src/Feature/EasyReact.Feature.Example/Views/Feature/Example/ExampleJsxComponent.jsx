class ExampleJsxComponent extends React.Component {
    render() {
        return (
            <div>
                <h2>Example react component</h2>
                <h4>
                    Component title: {this.props.data.Title}
                </h4>
            </div>
        );
    }
}