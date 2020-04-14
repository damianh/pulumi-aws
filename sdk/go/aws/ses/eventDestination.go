// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ses

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an SES event destination
type EventDestination struct {
	pulumi.CustomResourceState

	// CloudWatch destination for the events
	CloudwatchDestinations EventDestinationCloudwatchDestinationArrayOutput `pulumi:"cloudwatchDestinations"`
	// The name of the configuration set
	ConfigurationSetName pulumi.StringOutput `pulumi:"configurationSetName"`
	// If true, the event destination will be enabled
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Send the events to a kinesis firehose destination
	KinesisDestination EventDestinationKinesisDestinationPtrOutput `pulumi:"kinesisDestination"`
	// A list of matching types. May be any of `"send"`, `"reject"`, `"bounce"`, `"complaint"`, `"delivery"`, `"open"`, `"click"`, or `"renderingFailure"`.
	MatchingTypes pulumi.StringArrayOutput `pulumi:"matchingTypes"`
	// The name of the event destination
	Name pulumi.StringOutput `pulumi:"name"`
	// Send the events to an SNS Topic destination
	SnsDestination EventDestinationSnsDestinationPtrOutput `pulumi:"snsDestination"`
}

// NewEventDestination registers a new resource with the given unique name, arguments, and options.
func NewEventDestination(ctx *pulumi.Context,
	name string, args *EventDestinationArgs, opts ...pulumi.ResourceOption) (*EventDestination, error) {
	if args == nil || args.ConfigurationSetName == nil {
		return nil, errors.New("missing required argument 'ConfigurationSetName'")
	}
	if args == nil || args.MatchingTypes == nil {
		return nil, errors.New("missing required argument 'MatchingTypes'")
	}
	if args == nil {
		args = &EventDestinationArgs{}
	}
	var resource EventDestination
	err := ctx.RegisterResource("aws:ses/eventDestination:EventDestination", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEventDestination gets an existing EventDestination resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventDestination(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EventDestinationState, opts ...pulumi.ResourceOption) (*EventDestination, error) {
	var resource EventDestination
	err := ctx.ReadResource("aws:ses/eventDestination:EventDestination", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EventDestination resources.
type eventDestinationState struct {
	// CloudWatch destination for the events
	CloudwatchDestinations []EventDestinationCloudwatchDestination `pulumi:"cloudwatchDestinations"`
	// The name of the configuration set
	ConfigurationSetName *string `pulumi:"configurationSetName"`
	// If true, the event destination will be enabled
	Enabled *bool `pulumi:"enabled"`
	// Send the events to a kinesis firehose destination
	KinesisDestination *EventDestinationKinesisDestination `pulumi:"kinesisDestination"`
	// A list of matching types. May be any of `"send"`, `"reject"`, `"bounce"`, `"complaint"`, `"delivery"`, `"open"`, `"click"`, or `"renderingFailure"`.
	MatchingTypes []string `pulumi:"matchingTypes"`
	// The name of the event destination
	Name *string `pulumi:"name"`
	// Send the events to an SNS Topic destination
	SnsDestination *EventDestinationSnsDestination `pulumi:"snsDestination"`
}

type EventDestinationState struct {
	// CloudWatch destination for the events
	CloudwatchDestinations EventDestinationCloudwatchDestinationArrayInput
	// The name of the configuration set
	ConfigurationSetName pulumi.StringPtrInput
	// If true, the event destination will be enabled
	Enabled pulumi.BoolPtrInput
	// Send the events to a kinesis firehose destination
	KinesisDestination EventDestinationKinesisDestinationPtrInput
	// A list of matching types. May be any of `"send"`, `"reject"`, `"bounce"`, `"complaint"`, `"delivery"`, `"open"`, `"click"`, or `"renderingFailure"`.
	MatchingTypes pulumi.StringArrayInput
	// The name of the event destination
	Name pulumi.StringPtrInput
	// Send the events to an SNS Topic destination
	SnsDestination EventDestinationSnsDestinationPtrInput
}

func (EventDestinationState) ElementType() reflect.Type {
	return reflect.TypeOf((*eventDestinationState)(nil)).Elem()
}

type eventDestinationArgs struct {
	// CloudWatch destination for the events
	CloudwatchDestinations []EventDestinationCloudwatchDestination `pulumi:"cloudwatchDestinations"`
	// The name of the configuration set
	ConfigurationSetName string `pulumi:"configurationSetName"`
	// If true, the event destination will be enabled
	Enabled *bool `pulumi:"enabled"`
	// Send the events to a kinesis firehose destination
	KinesisDestination *EventDestinationKinesisDestination `pulumi:"kinesisDestination"`
	// A list of matching types. May be any of `"send"`, `"reject"`, `"bounce"`, `"complaint"`, `"delivery"`, `"open"`, `"click"`, or `"renderingFailure"`.
	MatchingTypes []string `pulumi:"matchingTypes"`
	// The name of the event destination
	Name *string `pulumi:"name"`
	// Send the events to an SNS Topic destination
	SnsDestination *EventDestinationSnsDestination `pulumi:"snsDestination"`
}

// The set of arguments for constructing a EventDestination resource.
type EventDestinationArgs struct {
	// CloudWatch destination for the events
	CloudwatchDestinations EventDestinationCloudwatchDestinationArrayInput
	// The name of the configuration set
	ConfigurationSetName pulumi.StringInput
	// If true, the event destination will be enabled
	Enabled pulumi.BoolPtrInput
	// Send the events to a kinesis firehose destination
	KinesisDestination EventDestinationKinesisDestinationPtrInput
	// A list of matching types. May be any of `"send"`, `"reject"`, `"bounce"`, `"complaint"`, `"delivery"`, `"open"`, `"click"`, or `"renderingFailure"`.
	MatchingTypes pulumi.StringArrayInput
	// The name of the event destination
	Name pulumi.StringPtrInput
	// Send the events to an SNS Topic destination
	SnsDestination EventDestinationSnsDestinationPtrInput
}

func (EventDestinationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eventDestinationArgs)(nil)).Elem()
}
