// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticloadbalancingv2

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Load Balancer Listener Rule resource.
// 
// > **Note:** `alb.ListenerRule` is known as `lb.ListenerRule`. The functionality is identical.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/lb_listener_rule_legacy.html.markdown.
type ListenerRule struct {
	s *pulumi.ResourceState
}

// NewListenerRule registers a new resource with the given unique name, arguments, and options.
func NewListenerRule(ctx *pulumi.Context,
	name string, args *ListenerRuleArgs, opts ...pulumi.ResourceOpt) (*ListenerRule, error) {
	if args == nil || args.Actions == nil {
		return nil, errors.New("missing required argument 'Actions'")
	}
	if args == nil || args.Conditions == nil {
		return nil, errors.New("missing required argument 'Conditions'")
	}
	if args == nil || args.ListenerArn == nil {
		return nil, errors.New("missing required argument 'ListenerArn'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["actions"] = nil
		inputs["conditions"] = nil
		inputs["listenerArn"] = nil
		inputs["priority"] = nil
	} else {
		inputs["actions"] = args.Actions
		inputs["conditions"] = args.Conditions
		inputs["listenerArn"] = args.ListenerArn
		inputs["priority"] = args.Priority
	}
	inputs["arn"] = nil
	s, err := ctx.RegisterResource("aws:elasticloadbalancingv2/listenerRule:ListenerRule", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ListenerRule{s: s}, nil
}

// GetListenerRule gets an existing ListenerRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetListenerRule(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ListenerRuleState, opts ...pulumi.ResourceOpt) (*ListenerRule, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["actions"] = state.Actions
		inputs["arn"] = state.Arn
		inputs["conditions"] = state.Conditions
		inputs["listenerArn"] = state.ListenerArn
		inputs["priority"] = state.Priority
	}
	s, err := ctx.ReadResource("aws:elasticloadbalancingv2/listenerRule:ListenerRule", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ListenerRule{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ListenerRule) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ListenerRule) ID() pulumi.IDOutput {
	return r.s.ID()
}

// An Action block. Action blocks are documented below.
func (r *ListenerRule) Actions() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["actions"])
}

// The ARN of the rule (matches `id`)
func (r *ListenerRule) Arn() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["arn"])
}

// A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.
func (r *ListenerRule) Conditions() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["conditions"])
}

// The ARN of the listener to which to attach the rule.
func (r *ListenerRule) ListenerArn() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["listenerArn"])
}

// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
func (r *ListenerRule) Priority() pulumi.IntOutput {
	return (pulumi.IntOutput)(r.s.State["priority"])
}

// Input properties used for looking up and filtering ListenerRule resources.
type ListenerRuleState struct {
	// An Action block. Action blocks are documented below.
	Actions interface{}
	// The ARN of the rule (matches `id`)
	Arn interface{}
	// A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.
	Conditions interface{}
	// The ARN of the listener to which to attach the rule.
	ListenerArn interface{}
	// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
	Priority interface{}
}

// The set of arguments for constructing a ListenerRule resource.
type ListenerRuleArgs struct {
	// An Action block. Action blocks are documented below.
	Actions interface{}
	// A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.
	Conditions interface{}
	// The ARN of the listener to which to attach the rule.
	ListenerArn interface{}
	// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
	Priority interface{}
}
